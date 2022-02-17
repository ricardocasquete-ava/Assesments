import React from "react";

import Plateau from "./plateau"
import Command from "./command"

const roverTurnVectors = [[0, 1], [1, 0], [0, -1], [-1, 0]];

var modulusFloor = (a, n) => {
  return (((a % n) + n) % n);
}

export default class RoverSimulator extends React.Component {
  constructor(props) {
    super(props);
    var direction = 0;
    var cardinal = (props.direction ?? "N");
    if (cardinal.length === 1 && cardinal.match(/[a-z]/i)) direction = this.toDirection(cardinal);
    const position = (props.roverPosition ?? [0, 0]);
    const dimensions = (props.dimensions ?? [5, 5]);
    this.state = {
      dimensions: dimensions,
      coordinates: (position[0] + " " + position[1] + " " + cardinal),
      commands: (props.commands ?? ""),
      default: {
        position: position,
        direction: direction,
        commands: (props.commands ?? "")
      },
      history: [{
        command: null,
        position: position,
        direction: direction
      }],
      stepNumber: 0,
      hasUI: (props.hasUI ?? true)
    };
  }

  toCardinal = (direction) => {
    switch (direction) {
      case 0:
        direction = "N";
        break;
      case 2:
        direction = "S";
        break;
      case 1:
        direction = "E";
        break;
      case 3:
        direction = "W";
        break;
    }
    return direction;
  }

  toDirection = (direction) => {
    switch (direction) {
      case "N":
        direction = 0;
        break;
      case "S":
        direction = 2;
        break;
      case "E":
        direction = 1;
        break;
      case "W":
        direction = 3;
        break;
    }
    return direction;
  }

  addCommand = (i) => {
    this.setState({
      commands: this.state.commands.concat(i)
    })
  }

  hasCommands = () => {
    return (this.state.history.length <= this.state.commands.length);
  }

  executeNextCommand = () => {
    if (this.hasCommands())
      this.processCommand(this.state.commands[this.state.stepNumber++]);
    else
      clearInterval(this.state.intervalId);
  }

  needsReset = () => {
    return (this.state.history.length > 1);
  }

  resetGame = () => {
    this.processCommand("");
  }

  executeAllCommands = () => {
    if (this.state.hasUI) {
      this.state.intervalId = setInterval(() => {
        this.executeNextCommand();
      }, 300);
    }
    else {
      while (this.hasCommands())
        this.executeNextCommand();
    }
  }

  processCommand = (command) => {
    const history = this.state.history;
    const current = history[(history.length - 1)];
    if (command === "") {
      const cardinal = this.toCardinal(this.state.default.direction);
      this.state.coordinates = (this.state.default.position[0] + " " + this.state.default.position[1] + " " + cardinal);
      if (this.state.hasUI) {
        this.setState({
          commands: this.state.default.commands,
          history: [{
            command: null,
            position: this.state.default.position,
            direction: this.state.default.direction
          }],
          stepNumber: 0
        });
      }
      else {
        this.state.stepNumber = 0;
        this.state.history = [{
          command: null,
          position: this.state.default.position,
          direction: this.state.default.direction
        }]
      }
    }
    else if (command === "M") {
      var commandDirection = [1, 1];
      const newPosition = current.position.map((p, index) => {
        return modulusFloor((p + (roverTurnVectors[current.direction][index] * commandDirection[index])), this.state.dimensions[index]);
      });
      const cardinal = this.toCardinal(current.direction);
      this.state.coordinates = (newPosition[0] + " " + newPosition[1] + " " + cardinal);
      if (this.state.hasUI) {
        this.setState({
          history: history.concat([{
            command: command,
            position: newPosition,
            direction: current.direction
          }])
        });
      }
      else {
        this.state.history.push({
          command: command,
          position: newPosition,
          direction: current.direction
        });
      }
    }
    else if (command === "L" || command === "R") {
      let newDirection = modulusFloor(current.direction + ((command === "R") ? 1 : -1), 4);
      const cardinal = this.toCardinal(newDirection);
      this.state.coordinates = (current.position[0] + " " + current.position[1] + " " + cardinal);
      if (this.state.hasUI) {
        this.setState({
          history: history.concat([{
            command: command,
            position: current.position,
            direction: newDirection
          }])
        });
      }
      else {
        this.state.history.push({
          command: command,
          position: current.position,
          direction: newDirection
        });
      }
    }
  }

  getCoordinates = () => {
    return this.state.coordinates;
  }

  render() {
    const currentHistory = this.state.history[this.state.stepNumber];

    return (
      <div className="game-container">
        <div className="game-info">
          {<span className="command-title">Commands: {this.state.commands}</span>}
          {<span className="coordinates-title">Coordinates: {this.state.coordinates}</span>}
          <div className="command-controls">
            <Command text="L" action="L" onClick={(i) => this.addCommand(i)} />
            <Command text="R" action="R" onClick={(i) => this.addCommand(i)} />
            <Command text="M" action="M" onClick={(i) => this.addCommand(i)} />
            <Command text="Run Command" disabled={!this.hasCommands()} onClick={() => this.executeNextCommand()} />
            <Command text="Execute All" disabled={!this.hasCommands()} onClick={() => this.executeAllCommands()} />
            <Command text="Reset" disabled={!this.needsReset()} onClick={() => this.resetGame()} />
          </div>
        </div>
        <div className="game-wrapper">
          <div className="game-board">
            <Plateau
              dimensions={this.state.dimensions}
              roverPosition={currentHistory.position}
              roverDirection={currentHistory.direction}
            />
          </div>
        </div>
      </div>
    );
  }
}