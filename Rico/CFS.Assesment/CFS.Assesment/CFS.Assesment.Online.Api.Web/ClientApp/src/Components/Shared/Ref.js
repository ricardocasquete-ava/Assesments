import React, { Component, Fragment } from "react";
import AppContext from "./AppContext";
import Common from "./Common";
import { Input, FormGroup } from "reactstrap";

const RefHelper = {
  getRefList(refCache, refKey) {
    var list = refCache[refKey];
    if (list == null || list.length === 0) {
      Common.log("Error while loaded the RefKey {0}. Assure key was loaded on App Start", [refKey]);
      Common.log(refCache);
      Common.log(list);
      return null;
    }

    return list;
  },

  getRefEntry(refCache, refKey, code) {
    Common.log("get RefEntry");
    Common.log(refCache);
    Common.log(refKey);
    Common.log(code);

    var list = this.getRefList(refCache, refKey);
    if (list != null && list[0] != null) {
      var entry = list.filter((entries) => {
        return entries.code === code;
      });
      if (entry === null || entry.length === 0) {
        Common.log("Requestd Ref Id {0} in list {1} Not Found} ", [code, refKey]);
      }
      return entry;
    }
    return null;
  },

  getCodeFor(state, refCache) {
    Common.log("Code For Code : {0} in {1}", [state.id, state.refKey]);

    var entry = this.getRefEntry(refCache, state.refKey, state.id);
    if (entry != null && entry.length > 0) {
      return entry[0].code;
    }

    return state.id;
    //TODO
    //return "Code Not Found for Id " + state.id;
  },

  getDescriptionFor(state, refCache) {
    Common.log("Description For");
    var entry = this.getRefEntry(refCache, state.refKey, state.id);
    if (entry != null && entry.length > 0) {
      return entry[0].description;
    }

    return state.id;
    //TODO
    //return "Description Not Found for Id " + state.id;
  },
};

export class RefLabel extends Component {
  constructor(props) {
    //calls the parent constructor
    super(props);

    //sets the state
    this.state = {
      refKey: "   ",
      id: 0,
      displayDescription: false,
    };

    //Bind Methods
  }

  static getDerivedStateFromProps(props, state) {
    return {
      refKey: props.refKey,
      id: props.id,
      displayDescription: props.displayDescription,
    };
  }

  render() {
    return <AppContext.Consumer>{(context) => <Fragment>{this.textFor(this.state, context.refCache)}</Fragment>}</AppContext.Consumer>;
  }

  textFor(state, refCache) {
    if (!state.displayDescription) {
      return RefHelper.getCodeFor(state, refCache);
    } else {
      return RefHelper.getDescriptionFor(state, refCache);
    }
  }
}

export class RefDropDown extends Component {
  constructor(props) {
    //calls the parent constructor
    super(props);

    //sets the state
      this.state = {
          refKey: "",
          id: 0,
          targetName: "",
          selectedValue: "",
          onChange: null,
          onChangeMethod: null,
          disabled: false,
          displayDescription: true,
      };

    //Bind Methods
    this.handleOptionChange.bind(this);
  }

    static getDerivedStateFromProps(props, state) {
        return {
            refKey: props.refKey,
            id: props.id,
            targetName: props.targetName,
            selectedValue: props.selectedValue,
            onChange: props.onChange,
            onChangeMethod: props.onChangeMethod,
            disabled: props.disabled ?? false,
            displayDescription: props.displayDescription ?? true,
        };
    }

    handleOptionChange = (event) => {
        Common.log("Drop Down Change to {0}", [event.target.value]);
        this.props.onChange(event.target.value);

        if (this.props.onChangeMethod != null) {
            Common.log('on change Method');
            this.props.onChangeMethod({ target: { name: this.state.targetName, value: event.target.value } });
        }
    };


  render() {
    return (
      <AppContext.Consumer>
        {(context) => (
          <Fragment>
            <FormGroup>
              <Input type="select" custom="true" value={this.state.selectedValue} onChange={this.handleOptionChange.bind(this)} disabled={this.state.disabled}>
                {this.itemsFor(this.state.refKey, context.refCache).map((row, index) => (
                  <option key={index} value={row.code}>
                    {this.state.displayDescription ? row.description : row.code}
                  </option>
                ))}
              </Input>
            </FormGroup>
          </Fragment>
        )}
      </AppContext.Consumer>
    );
  }

  itemsFor(refKey, refCache) {
    var list = RefHelper.getRefList(refCache, refKey);
    if (list == null) {
      return [];
    }
    return list;
  }
}
