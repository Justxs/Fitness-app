import "../custom.scss";
import CaloryCards from "../components/dashboard_components/CaloryCards";
import WeightGraph from "../components/dashboard_components/WeightGraph";

function DashboardPage() {
  return (
    <div className="Dash_board_page">
      <CaloryCards />
      <WeightGraph />
    </div>
  );
}

export default DashboardPage;
