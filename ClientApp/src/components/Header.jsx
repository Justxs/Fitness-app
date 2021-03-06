import logo from "../icons/logo.svg";
import hamburger from "../icons/Hamburger.png";
import { Navbar, Nav, Button } from "react-bootstrap";
import { Link } from "react-router-dom";
import "../custom.scss";
import useAuth from "../hooks/useAuth";
import PropTypes from "prop-types";


Header.propTypes = {
  isLoggedIn: PropTypes.bool,
};

function Header({isLoggedIn}) {
  const { signOut } = useAuth();
  if(isLoggedIn){
    return (
      <div className="bg-light">
        <Navbar collapseOnSelect expand="lg" bg="transparent" variant="warning">
          <Navbar.Brand>
            <img src={logo} width="60px" height="40px" alt="logo" />
            <b>SportyPal</b>
          </Navbar.Brand>
  
          <Navbar.Toggle aria-controls="basic-navbar-nav">
            <span>
              <img src={hamburger} width="40px" height="40px" alt="hamburger" />
            </span>
          </Navbar.Toggle>
          <Navbar.Collapse id="responsive-navbar-nav">
            <Nav variant="pills">
              <Nav.Link
                className="p-3"
                eventKey="link-1"
                as={Link}
                to="/dashboard"
              >
                <b>Dashboard</b>
              </Nav.Link>
              <Nav.Link className="p-3" eventKey="link-2" as={Link} to="/food">
                <b>Food entry</b>
              </Nav.Link>
              <Nav.Link
                className="p-3"
                eventKey="link-3"
                as={Link}
                to="/userSettings"
              >
                <b>Settings</b>
              </Nav.Link>
              <Button className="text-light m-2" variant="primary" onClick={() => signOut()}>
                <b>Logout</b>
              </Button>
            </Nav>
          </Navbar.Collapse>
        </Navbar>
      </div>
    );
  }
  else{
    return (
      <div className="bg-light">
        <Navbar collapseOnSelect expand="lg" bg="transparent" variant="warning">
          <Navbar.Brand>
            <img src={logo} width="60px" height="40px" alt="logo" />
            <b>SportyPal</b>
          </Navbar.Brand>
  
          <Navbar.Toggle aria-controls="basic-navbar-nav">
            <span>
              <img src={hamburger} width="40px" height="40px" alt="hamburger" />
            </span>
          </Navbar.Toggle>
          <Navbar.Collapse id="responsive-navbar-nav">
            <Nav variant="pills">
              <Nav.Link className="p-3" eventKey="link-0" as={Link} to="/home">
                <b>Home</b>
              </Nav.Link>
            </Nav>
          </Navbar.Collapse>
        </Navbar>
      </div>
    );
  }
}

export default Header;
