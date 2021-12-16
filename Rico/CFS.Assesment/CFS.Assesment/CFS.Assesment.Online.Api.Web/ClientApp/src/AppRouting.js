import React, { Component, Fragment } from "react";
import { Route } from "react-router";
import AppContext from "./Components/Shared/AppContext";
import Common from "./Components/Shared/Common";

import MarsRovers from "./Components/Application/MarsRovers";
import Landing from "./Components/Application/Landing";
import Patterns from "./Components/Application/Patterns";

export default class AppRouting extends Component {
  constructor(props) {
    //Init Parent Constructor
    super(props);
    Common.log("Component Init -> /AppRouting");

    //Sets State
    this.state = {};

    //Bind Methods
  }

  componentDidMount() {}

  render() {
    return (
      <AppContext.Consumer>
        {(context) => (
          <Fragment>
            <Route exact path="/" component={Landing} />
            <Route exact path="/MarsRovers" component={MarsRovers} />
            <Route exact path="/Patterns" component={Patterns} />
          </Fragment>
        )}
      </AppContext.Consumer>
    );
  }
}
