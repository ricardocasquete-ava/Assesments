import React, { useEffect } from "react";
import Common from "../../Shared/Common";

import { Container, Row, Col } from 'reactstrap';

const AppWrapperContainer = (props) => {

    useEffect(() => {
        Common.log("Component Init -> /Form Wrapper");
    });

    return (
        <Container fluid>
            <Row>
                <Col>
                    {props.children}
                </Col>
            </Row>
        </Container>
    );
};

export default AppWrapperContainer;
