import React, { Fragment, useEffect, useState, useRef } from "react";

import Common from "../Shared/Common";
import Block from "../Controls/Form/Block";

import { Jumbotron  } from "reactstrap";

const Landing = (props) => {

    useEffect(() => {
        Common.log("Component Init -> /Landking");
    });

    return (
        <Fragment>

            <Block name="landing-intro">
                <Jumbotron>
                    <p>
                        The Assesment contains 2 pages connected to a REST API; which can be accessed via the Menu
                    </p>
                    <ul>
                        <li>
                            Mars Rovers Coding Challenge
                        </li>
                        <li>
                            A Singleton + Factory Pattern Implementatino
                        </li>
                    </ul>
                </Jumbotron>
            </Block>


        </Fragment>
    );
};


export default Landing;
