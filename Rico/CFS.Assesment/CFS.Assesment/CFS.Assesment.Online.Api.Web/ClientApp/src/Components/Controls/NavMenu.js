import React, { Component, Fragment } from "react";
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavLink } from "reactstrap";
import { Link } from "react-router-dom";
import AppContext from "../Shared/AppContext";


export class NavMenu extends Component {
  static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true,
            displaySecurityControls: props.displaySecurityControls,
            menuItems: [
                {
                    items: [
                        {
                            linkLabel: "Mars Rovers",
                            linkUrl: "/MarsRovers",
                        },
                        {
                            linkLabel: "Patterns",
                            linkUrl: "/Patterns",
                        },
                    ],
                }
            ]
        }
    }


  toggleNavbar() {
    this.setState({
      collapsed: !this.state.collapsed,
    });
  }

  render() {
    return (
      <AppContext.Consumer>
        {(context) => (
          <header>
            <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
              <Container>
                <NavbarBrand tag={Link} to="/">
                  CFS Assesment
                </NavbarBrand>
                <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                  <ul className="navbar-nav flex-grow">
                    {this.state.menuItems
                      .map((item) =>
                        item.items.map((i, index) => (
                          <Fragment key={index}>
                            <NavLink tag={Link} className="menu-item" to={i.linkUrl}>
                              {i.linkLabel}
                            </NavLink>
                          </Fragment>
                        ))
                      )}
                  </ul>
                </Collapse>
              </Container>
            </Navbar>
          </header>
        )}
      </AppContext.Consumer>
    );
  }
}
