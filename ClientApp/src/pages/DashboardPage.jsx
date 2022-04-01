import '../custom.scss';
import logo from '../logo.svg';
import { Navbar } from 'react-bootstrap'

function DashboardPage() {
  return (
    <div className="Dash board page">
      <Navbar bg="light" variant="primary" fixed="top">
      <Navbar.Brand >
          Sporty
          <img src={logo} width="40px" height="40px" alt='logo'/>
        </Navbar.Brand>

      </Navbar>

    </div>
  );
}

export default DashboardPage;
