import PropTypes from "prop-types";
import { Outlet, Navigate } from "react-router";

AppRoute.propTypes = {
  condition: PropTypes.bool,
  redirectionPath: PropTypes.string,
};

function AppRoute({ condition, redirectionPath }) {
  return condition ? <Outlet /> : <Navigate to={redirectionPath} />;
}

export default AppRoute;
