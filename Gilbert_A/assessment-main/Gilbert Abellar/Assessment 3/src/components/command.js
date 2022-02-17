import React from "react";

export default class Command extends React.Component {
  render() {
    return (
      <button className="input" disabled={this.props.disabled || false} onClick={() => { this.props.onClick(this.props.action) }}>
        {this.props.text}
      </button>
    )
  }
}