import logo from '../icons/logo.svg';
import { Navbar, Nav } from 'react-bootstrap'
import { Link } from "react-router-dom";

function Header() {
  return (

    <div>
        <Navbar bg="light" variant="light" sticky="top" expand="sm" collapseOnSelect>
            <Navbar.Brand >
                <img src={logo} width="60px" height="40px" alt='logo'/>
                <b>SportyAPP</b>
            </Navbar.Brand>
            <Navbar.Toggle />
              <Navbar.Collapse>
                <Nav variant="pills" defaultActiveKey="/home">
                  <Nav.Link as={Link} to="/home" ><b>Home</b></Nav.Link>
                  <Nav.Link as={Link} to="/dashboard"><b>Dashboard</b></Nav.Link>
                  <Nav.Link as={Link} to="/userSettings"><b>Settings</b></Nav.Link>
                </Nav>
        </Navbar.Collapse>

        </Navbar>
      </div>
      
  );
}

export default Header;