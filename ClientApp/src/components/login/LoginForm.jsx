import { useState } from "react";
import InputField from "./InputField";
import InputCheckbox from "./InputCheckbox";

function LoginForm({ redirection, loginFunc, isLoading, handleSubmit }) {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [rememberMe, setRememberMe] = useState(false);

  const onFormChange = (e) => {
    switch (e.target.name) {
      case "email":
        setEmail(e.target.value);
        break;
      case "password":
        setPassword(e.target.value);
        break;
      case "rememberMe":
        setRememberMe(e.target.checked);
        break;
      default:
        break;
    }
  };

  return (
    <div
      className="card justify-content-center mx-auto  align-middle p-4"
      style={{ width: "25rem", top: "10rem" }}
    >
      <form>
        <InputField
          type="email"
          name="email"
          value={email}
          description="Enter your email"
          onChange={(e) => onFormChange(e)}
          placeholder="example@domain.com"
          disabled={isLoading}
          required={true}
        />
        <InputField
          type="password"
          name="password"
          value={password}
          description="Enter your password"
          onChange={(e) => onFormChange(e)}
          placeholder=""
          disabled={isLoading}
          required={true}
        />
        <InputCheckbox
          name="rememberMe"
          value={rememberMe}
          description="Remember me"
          onChange={(e) => onFormChange(e)}
          disabled={isLoading}
          required={false}
        />
      </form>
      <button
        className="btn-primary m-2 w-25"
        onClick={() => loginFunc(email, password)}
      >
        Login
      </button>
    </div>
  );
}

export default LoginForm;
