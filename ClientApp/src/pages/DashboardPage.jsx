import "../custom.scss";
import CaloryCards from "../components/dashboard_components/CaloryCards";
import WeightGraph from "../components/dashboard_components/WeightGraph";
import { Col, Row } from "react-bootstrap";
import CaloriesRecomendation from "../components/dashboard_components/CaloriesRecomendation";

function DashboardPage() {
  return (
    <div className="Dash_board_page">
      <Row className="m-2">
        <CaloryCards />
      </Row>
      <Row className="container-fluid m-1 my-2 md-2">
        <Col md={7}>
          <WeightGraph />
        </Col>
        <Col md={5} className="my-2"> 
          <CaloriesRecomendation />
        </Col>
        
      </Row>
      
    </div>
  );
}

export default DashboardPage;
