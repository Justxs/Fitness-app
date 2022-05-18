import { useNavigate } from "react-router-dom";
import LoginForm from "../components/login/LoginForm";
import useAuth from "../hooks/useAuth";

function LoginPage() {
  const navigate = useNavigate();
  const { signIn } = useAuth();
  return (
    <LoginForm
      redirection={() => navigate("/dashboard")}
      loginFunc={signIn}
      isLoading={false}
    />
  );
}

export default LoginPage;
