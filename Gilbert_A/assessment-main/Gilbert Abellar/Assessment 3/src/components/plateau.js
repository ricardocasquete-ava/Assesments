import React from "react";

import PlateauTile from "./plateau-tile"

export default class Plateau extends React.Component {
  renderRow(row) {
    var tiles = [];
    for (let col = 0; col < this.props.dimensions[0]; ++col) {
      var hasRover = (col === this.props.roverPosition[0] && row === this.props.roverPosition[1]);
      tiles.push(
        <PlateauTile
          key={[col, row]}
          value={[col, row]}
          hasRover={hasRover}
          direction={this.props.roverDirection}
      />);
    }
    return (<tr className="row" key={row} >{tiles}</tr>);
  }

  render() {
    var rows = [];
    for (let row = (this.props.dimensions[1] - 1); row >= 0; --row)
      rows.push(this.renderRow(row));
    return (<table><tbody>{rows}</tbody></table>);
  }
}