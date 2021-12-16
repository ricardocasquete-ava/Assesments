import React, { Component } from 'react';
import { NavLink, UncontrolledDropdown, DropdownToggle, DropdownMenu, DropdownItem } from 'reactstrap';
import { Link } from 'react-router-dom';

export class NavMenuItem extends Component {
  constructor (props) {
    super(props);

    this.state = {};
  }

  render () {
      return (
          <UncontrolledDropdown nav inNavbar>
              <DropdownToggle nav caret>
                  {this.props.Label}
                </DropdownToggle>
              <DropdownMenu right>
                  {this.props.Items.map(item =>
                      <DropdownItem key={item.LinkUrl}>
                          <NavLink tag={Link} className="text-dark" to={item.LinkUrl}>{item.LinkLabel}</NavLink>
                      </DropdownItem>
                  )}
              </DropdownMenu>              

          </UncontrolledDropdown>
      );
  }
}
