import logo from '../icons/logo.svg';
import { Navbar, Nav } from 'react-bootstrap'
import { Link } from "react-router-dom";
import '../custom.scss';

function Header() {
  return (

    <div>
        <Navbar collapseOnSelect expand="lg" bg="light" variant="primary">
          <Navbar.Brand >
            <img src={logo} width="60px" height="40px" alt='logo'/>
            <b>SportyPal</b>
          </Navbar.Brand>

          <Navbar.Toggle className='border-primary m-3'/>
            <Navbar.Collapse>
              <Nav variant="pills">
                <Nav.Link className='p-3' eventKey="link-0" as={Link} to="/home"><b>Home</b></Nav.Link>
                <Nav.Link className='p-3' eventKey="link-1" as={Link} to="/dashboard"><b>Dashboard</b></Nav.Link>
                <Nav.Link className='p-3' eventKey="link-2" as={Link} to="/userSettings"><b>Settings</b></Nav.Link>
              </Nav>
            </Navbar.Collapse>

        </Navbar>
      </div>
      
  );
}

export default Header;