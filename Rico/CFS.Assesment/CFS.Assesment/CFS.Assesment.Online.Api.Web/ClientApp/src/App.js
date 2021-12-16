import React, { Component } from 'react';
import './Resources/Css/Site.css';

import Common from './Components/Shared/Common';
import RefAPI from './Components/Shared/RefAPI';
import AppProvider from './Components/Shared/AppProvider';

import AppRouting from './AppRouting';
import { NavMenu } from './Components/Controls/NavMenu';
import AppWrapper from './Components/Controls/Form/AppWrapper';
import AppWrapperContainer from './Components/Controls/Form/AppWrapperContainer';
import { NotificationContainer } from 'react-notifications';

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
        Common.log("Component Init -> /App");

        this.state = {

            hasConfig: false,
            config: {
            }
        };
    }

    componentDidMount() {
        RefAPI.getConfig(this.getConfigCallback);
    }

    //#region Get and Set Branch Code

    getConfigCallback = (data) => {
        Common.log("Configuration Loaded");
        Common.log(data);

        //Initialize the Console
        Common.setLog({ consoleEnabled: data.consoleEnabled, consoleLevel: data.consoleLevel });

        //Set Config State -> it will configure Menu / Security / Footer...
        this.setState({ hasConfig: true, config: data });
    }

    //#endregion

  render () {
      return (
          <AppProvider>
            <AppWrapper wrapperClass={this.state.brandCode}>
                <NavMenu />
                <AppWrapperContainer>
                    <AppRouting />
                    <NotificationContainer />
                </AppWrapperContainer>
            </AppWrapper>
          </AppProvider>
    );
  }
}



