import "../custom.scss";
import CaloryCards from "../components/dashboard_components/CaloryCards";
import WeightGraph from "../components/dashboard_components/WeightGraph";
import { Row } from "react-bootstrap";

function DashboardPage() {
  return (
    <div className="Dash_board_page">
      <Row>
        <CaloryCards />
      </Row>
      <Row className="container-fluid m-2">
        <WeightGraph />
      </Row>
      
    </div>
  );
}

export default DashboardPage;
