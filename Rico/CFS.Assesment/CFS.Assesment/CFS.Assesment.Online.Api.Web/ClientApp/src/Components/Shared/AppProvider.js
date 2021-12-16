import React, { Component } from "react";

import Common from "./Common";
import AppContext from "./AppContext";
import RefAPI from "./RefAPI";

class AppProvider extends Component {
  //Component Initialization
  constructor(props) {
    super(props); //Init Parents Contructor Method
    Common.log("Component Init -> AppProvider");

    //Sets the Initial State
    this.state = {
      hasConfig: false,
      brand: {
        brandId: 0,
        brandCode: "",
      },
      refCache: {},
      session: {},
      config: {},
    };

    //load RefData in Batch
    RefAPI.getBatch({}, this.getRefBatchCallback);
    RefAPI.getConfig(this.getConfigCallback);
  }

  //Renders the HTML to the DOM
  render() {
    return (
      <AppContext.Provider
        value={{
          refCache: this.state.refCache,
          config: this.state.config,
          brand: this.state.brand,
        }}
      >
        {this.props.children}
      </AppContext.Provider>
    );
  }

  //Called after Component is updated in the DOM
  componentDidUpdate() {}

  ///#Region Reference Data Dictionary Methods

  getRefCallback = (data, callbackData) => {
    Common.log("Ref Data Loaded for {0}", [callbackData.refKey]);
    Common.log(data);

    var refCache = this.state.refCache;
    refCache[callbackData.refKey] = data;

    this.setState({ refCache: refCache });
  };

  getRefBatchCallback = (data, callbackData) => {
    Common.log("Ref Batch CallBack. RequestedKeys =>");
    Common.log(callbackData);

    Common.log(data);
    if (data != null && data.length > 0) {
      var refCache = this.state.refCache;

      var refEntry;
      for (refEntry in data) {
        refCache[data[refEntry].refTypeName] = data[refEntry].values;
      }
    }
    Common.log("loaded Ref Cache");
    Common.log(refCache);

    this.setState({ refCache: refCache });
  };

  getConfigCallback = (data) => {
    Common.log("Config Successfully loaded");
    this.setState({ hasConfig: true, config: data });
  };

  setBrandCodeCallback = (data) => {
    Common.log("Brand Loaded -> {0}", [data]);
    this.setState({ brand: data });
  };
  ///endregion
}

export default AppProvider;
