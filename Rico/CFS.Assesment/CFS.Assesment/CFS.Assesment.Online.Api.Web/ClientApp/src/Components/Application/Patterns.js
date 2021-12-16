import React, { Fragment, useEffect, useState, useRef } from "react";
import { RefDropDown } from "../Shared/Ref";

import Common from "../Shared/Common";
import Block from "../Controls/Form/Block";

import { Col, Row, Container, FormGroup, Jumbotron } from "reactstrap";

import imgDefinition from '../../Resources/Images/Definition.png'
import imgImplementations from '../../Resources/Images/Implementations.png'
import PatternsAPI from "./Shared/PatternsAPI";

const Patterns = (props) => {

    const [userContextId, setUserContextId] = useState("");
    const [fee, setFee] = useState("--No Response--");

    useEffect(() => {
        Common.log("Component Init -> /Patters");
    });

    function retrieveFeeForContext(event) {
        var requestedContext = event.target.value;

        Common.log("perform operation -> {0}", [requestedContext]);
        PatternsAPI.getFee({ context: requestedContext }, retrieveFeeForContextCallBack, { 'userContext': requestedContext });
    }

    function retrieveFeeForContextCallBack(data, callbackData) {
        Common.log("fee Callback for user Context {0}", callbackData.userContext);
        setFee(data.response);
    }

    return (
        <Fragment>

            <Block name="patterns-intro">
                <Jumbotron>
                    <p>
                        A Singleton, Factory and Abstract Factory Pattern Implementation sits behind this UI.
                        The Abstract factory part of it is fixed; however the Factory is dynamic.
                    </p>
                    <p>
                        Select the User Context / Enviornment / Brand... (or any other given name / concept...)
                        There is a given inteface IFeeCalculation; which has different Implementations for the different Contexts.
                    </p>
                    <p>
                        If an implemnetation for the interface for a requested Context is not found; the default implementation will be returned
                    </p>
                </Jumbotron>
            </Block>

            <Block name="patterns-example">
                <Container>
                    <Row>
                        <Col>
                            <FormGroup>
                                <RefDropDown refKey="userContext"
                                    selectedValue={userContextId} targetName="userContextId"
                                    onChange={setUserContextId} onChangeMethod={retrieveFeeForContext}
                                />
                            </FormGroup>
                        </Col>
                        <Col>
                            <Jumbotron>
                                <p>
                                    Fee Calculation for the Given Context
                                </p>
                                <p>
                                    <b>{fee}</b>
                                </p>
                            </Jumbotron>
                        </Col>
                    </Row>
                </Container>
            </Block>

            <Block name="patterns-code-examples">
                <Container>
                    <Row>
                        <Col lg="6">
                            <p>
                                <b>IFeeCalculation definition and default Implmentation</b>
                            </p>
                            <p>
                                <img src={imgDefinition} className="img-fluid" alt=""/>
                            </p>
                        </Col>
                        <Col lg="6">
                            <p>
                                <b>Different Context Implementations</b>
                            </p>
                            <p>
                                <img src={imgImplementations} className="img-fluid" alt=""/>
                            </p>
                        </Col>
                    </Row>
                </Container>
            </Block>

        </Fragment>
    );
};


export default Patterns;
