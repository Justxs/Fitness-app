import { Routes, Route, Navigate } from "react-router-dom";
import AppRoute from "./AppRoute";
import DashboardPage from "../../pages/DashboardPage";
import HomePage from "../../pages/HomePage";
import LoginPage from "../../pages/LoginPage";
import PageNotFoundPage from "../../pages/PageNotFoundPage";
import UserSettingsPage from "../../pages/UserSettingsPage";
import FoodPage from "../../pages/FoodPage";
import PropTypes from "prop-types";

AppRoutes.propTypes = {
  isLoggedIn: PropTypes.bool,
};

function AppRoutes({ isLoggedIn }) {
  return (
    <Routes>
      <Route path="/home" element={<HomePage />} />
      <Route
        element={<AppRoute condition={isLoggedIn} redirectionPath={"/home"} />}
      >
        <Route path="/" element={<Navigate to="/dashboard" />} />
        <Route path="/dashboard" element={<DashboardPage />} />
        <Route path="/userSettings" element={<UserSettingsPage />} />
        <Route path="/food" element={<FoodPage />} />
      </Route>
      <Route
        element={
          <AppRoute condition={!isLoggedIn} redirectionPath={"/dashboard"} />
        }
      >
        <Route path="/" element={<Navigate to="/home" />} />
        <Route path="/login" element={<LoginPage />} />
      </Route>
      <Route path="*" element={<PageNotFoundPage />} />
    </Routes>
  );
}

export default AppRoutes;
