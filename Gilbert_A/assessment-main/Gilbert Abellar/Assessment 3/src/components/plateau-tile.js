import React from "react";

import roverNorth from "../img/rover-north.png";
import roverSouth from "../img/rover-south.png";
import roverEast from "../img/rover-east.png";
import roverWest from "../img/rover-west.png";

import plateauPath from "../img/plateau.png"

const backgroundCSSPaths = {
  rover: [
    `url(${roverNorth})`,
    `url(${roverEast})`,
    `url(${roverSouth})`,
    `url(${roverWest})`,
  ],
  tile: `url(${plateauPath})`,
}

export default class PlateauTile extends React.Component {
  render() {
    var classString = `tile ${((this.props.hasRover) ? "rover" : "")}`
    let backgroundCSS = backgroundCSSPaths.tile;
    if (this.props.hasRover) backgroundCSS = backgroundCSSPaths.rover[this.props.direction];
    return (
      <td className={classString} style={{ background: backgroundCSS }} ></td>
    )
  }
}