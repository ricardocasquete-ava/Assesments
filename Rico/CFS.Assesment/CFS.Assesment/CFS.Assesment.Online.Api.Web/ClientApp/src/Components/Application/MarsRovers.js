import React, { Fragment, useEffect, useState, useRef } from "react";
import { RefDropDown } from "../Shared/Ref";

import Common from "../Shared/Common";
import Block from "../Controls/Form/Block";

import { Form, Col, Row, Container, FormGroup, Label, Input, Jumbotron  } from "reactstrap";
import { Button } from "reactstrap";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBolt, faChevronCircleLeft, faChevronCircleRight, faDrawPolygon, faUndo } from "@fortawesome/free-solid-svg-icons";
import RoversAPI from "./Shared/RoversAPI ";

const MarsRovers = (props) => {

    const [operationId, setOperationId] = useState("L");
    const [cardinalPositionId, setCardinalPositionId] = useState("N");

    const [height, setHeight] = useState(0);
    const [length, setLength] = useState(0);
    const [X, setX] = useState(0);
    const [Y, setY] = useState(0);

    const [dimensions, setDimensions] = useState({ height: 0, length:0 });
    const [position, setPosition] = useState({ xCoordinate: 0, yCoordinate:0, orientation:'N'});
    const [drawPlateau, setDrawPlateau] = useState(false);

    const [model, setModel] = useState({
        plateau: { height: 0, length: 0 },
        position: { xCoordinate: 0, yCoordinate: 0, orientation : ""}
    });

    useEffect(() => {
        Common.log("Component Init -> /MarsRovers");
    });

    function resetClick() {
        setDrawPlateau(false);
        setX(0);
        setY(0);
        setHeight(0);
        setLength(0);
    }

    function drawPlateauClick() {

        setDimensions({ height: Number(height), length: Number(length) });
        setPosition({ xCoordinate: Number(X), yCoordinate: Number(Y), orientation: cardinalPositionId });

        var currentModel = {
            plateau: { height: Number(height), length: Number(length) },
            position: { xCoordinate: Number(X), yCoordinate: Number(Y), orientation: cardinalPositionId }
        };

        setModel(currentModel);
        setDrawPlateau(true);
    }

    function performOperation(action) {
        Common.log("perform operation -> {0}", [action]);
        RoversAPI.performMove({ roverController: model, action: action }, performOperationCallBack);
    }

    function performOperationCallBack(data, callbackData) {
        Common.log("performOperation Callback");
        Common.log(data);

        setPosition(data.position);
        var udpatedModel = {
            plateau: data.plateau,
            position: data.position
        };
        setModel(udpatedModel);
    }

    return (
        <Fragment>

            <Block name="roves-intro">
                <Jumbotron>
                    <p>
                        Test the Mars Rovers Challenge by:
                    </p>
                    <ul>
                        <li>
                            Introduce first dimensions for the Plateau (i.e 5x5, 4x6...). It will create a grid based on those dimensions.
                        </li>
                        <li>
                            Enter a Position for the Rovers within the Plateau (X & Y coordinate) and select an start orientation (N/S/W/E)
                        </li>
                        <li>
                            Use the Controls to Turn the Orientation of the Rover (Left and Right) and move it forward based on the (N/S/W/E) orientation
                        </li>
                    </ul>
                </Jumbotron>
            </Block>

            <Block name="rovers-controls">
                <Form>
                    <Container>
                        <Row>
                            <Col lg="3">
                                <FormGroup>
                                    <Label>Plateu and Rover Configuration</Label>
                                </FormGroup>
                            </Col>
                            <Col lg="3">
                                <FormGroup>
                                    <Input type="text" placeholder="Enter Plateau Length" type="number"
                                        value={length !== 0 ? length : ""}
                                        onChange={event => setLength(Number(event.target.value))} />
                                </FormGroup>
                            </Col>
                            <Col lg="3">
                                <FormGroup>
                                    <Input type="text" placeholder="Enter Plateau Height" type="number"
                                        value={height !== 0 ? height : ""}
                                        onChange={event => setHeight(Number(event.target.value))} />
                                </FormGroup>
                            </Col>
                        </Row>

                        <Row>
                            <Col lg={{ size: 3, offset: 3 }}>
                                <FormGroup>
                                    <Input type="text" placeholder="X Coordinate for the Rover" type="number"
                                        value={X !== 0 ? X : ""}
                                        onChange={event => setX(event.target.value)} />
                                </FormGroup>
                            </Col>
                            <Col lg="3">
                                <FormGroup>
                                    <Input type="text" placeholder="Y Coordinate for the Rover" type="number"
                                        value={Y !== 0 ? Y : ""}
                                        onChange={event => setY(event.target.value)} />
                                </FormGroup>
                            </Col>
                        </Row>

                        <Row>
                            <Col lg={{size:3,offset:3}}>
                                <FormGroup>
                                    <RefDropDown refKey="cardinalPosition" selectedValue={cardinalPositionId}
                                        targetName="cardinalPositionId"
                                        onChange={setCardinalPositionId} />
                                </FormGroup>
                            </Col>
                            <Col lg="3" className="text-right">
                                <FormGroup>
                                    <Button className="btn-warning" onClick={drawPlateauClick}> <FontAwesomeIcon icon={faDrawPolygon} /> Set Plateau</Button><span> </span>
                                    <Button className="btn-danger" onClick={resetClick}> <FontAwesomeIcon icon={faUndo} /> </Button>
                                </FormGroup>
                            </Col>

                        </Row>

                        <Row>
                            <Col lg="3">
                                <FormGroup>
                                    <Label>Rover Controls</Label>
                                </FormGroup>
                            </Col>
                            <Col lg="6" className="text-right">
                                <FormGroup>
                                    <Button className="btn-success" onClick={e => { performOperation('L'); }}> <FontAwesomeIcon icon={faChevronCircleLeft} /> L</Button><span> </span>
                                    <Button className="btn-primary" onClick={e => { performOperation('M'); }}>Forward <FontAwesomeIcon icon={faBolt} /></Button><span> </span>
                                    <Button className="btn-success" onClick={e => { performOperation('R'); }}> R <FontAwesomeIcon icon={faChevronCircleRight} /></Button>
                                </FormGroup>
                            </Col>
                        </Row>

                    </Container>
                </Form>
            </Block>

            <Block>
                <Container>
                    <Row>
                        <Col lg={{ size: 6, offset: 3 }}>

                            {drawPlateau &&
                                <Plateau
                                dimensions={dimensions}
                                startPosition={position}
                                />
                            }

                        </Col>
                    </Row>
                </Container>
            </Block>

        </Fragment>
    );
};

const Plateau = (props) => {

    const pxMultiplier = 100; //Size of the boxes
    const pxPadding = 15; //Padding for the Rover

    const canvas = useRef();
    const [dimensions, setDimensions] = useState(props.dimensions);
    const [startPosition, setStartPosition] = useState(props.startPosition);

    let ctx = null;

    useEffect(() => {
        Common.log("Component Init -> /Plateau");
        Common.log(props);

        setDimensions(props.dimensions);
        setStartPosition(props.startPosition);

        //Create Canvas
        const canvasEle = canvas.current;
        canvasEle.width = dimensions.length * pxMultiplier;
        canvasEle.height = dimensions.height * pxMultiplier;

        //Draw Lines
        ctx = canvasEle.getContext("2d");
        for (var i = 0; i < dimensions.length; i++) {
            for (var j = 0; j < dimensions.height; j++) {
                drawRect({ x: i * pxMultiplier, y: j * pxMultiplier });
            }
        }

        //Set Rover
        if ((startPosition != null)
            && (startPosition.xCoordinate >= 0) && (startPosition.xCoordinate <= dimensions.length)
            && (startPosition.yCoordinate >= 0) && (startPosition.yCoordinate <= dimensions.height)) {
            drawFillRect(startPosition, dimensions.height);
        }
    });


    const drawRect = (coordinates = {}) => {
        const { x, y } = coordinates;

        ctx.beginPath();
        ctx.strokeStyle = 'red';
        ctx.lineWidth = 1;
        ctx.rect(x, y, pxMultiplier, pxMultiplier);
        ctx.stroke();
    }

    const drawFillRect = (coordinates, height = {}) => {
        const { xCoordinate, yCoordinate } = coordinates;

        ctx.beginPath();
        ctx.font = "100px Arial Bold";
        ctx.fillText(coordinates.orientation, ((xCoordinate - 1) * pxMultiplier) + pxPadding, (((height + 1) - yCoordinate) * pxMultiplier) - pxPadding);
    }

    return (
        <Fragment>
            <canvas ref={canvas}></canvas>
        </Fragment>
    );
};

export default MarsRovers;
