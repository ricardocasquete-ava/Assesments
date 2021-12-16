import React, { useEffect, useState } from "react";
import { Container, Row, Col } from 'reactstrap';
import Common from "../../Shared/Common";

const Block = (props) => {
    const [blockName, setBlockName] = useState("");

    useEffect(() => {
        setBlockName(props.name);
        Common.log("Component Init -> /Block " + blockName);
    }, [blockName]);

    return (
        <Container>
            <Row>
                <Col>
                    {props.children}
                </Col>
            </Row>
        </Container>
    );
};

export default Block;
