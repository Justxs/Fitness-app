import { useState } from "react";
import "./LoginForm.css";

function LoginForm({ loginFunc, isLoading }) {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [rememberPassword, setRememberPassword] = useState(false);

  const onFormChange = (e) => {
    switch (e.target.name) {
      case "email":
        setEmail(e.target.value);
        break;
      case "password":
        setPassword(e.target.value);
        break;
      case "rememberPassword":
        setRememberPassword(e.target.checked);
        break;
      default:
        break;
    }
  };

  const onLogin = () => {
    loginFunc(email, password, rememberPassword);
  };

  return (
    <div className="card justify-content-center mx-auto  align-middle p-4 form">
      <form>
        <label htmlFor={email}>{"Enter your email"}</label>
        <div className="input-group mb-3">
          <input
            type={"email"}
            className="form-control"
            id={"email"}
            name={"email"}
            value={email}
            onChange={(e) => onFormChange(e)}
            placeholder={"example@domain.com"}
            disabled={isLoading}
            required={true}
          />
        </div>
        <label htmlFor={"password"}>{"Enter your password"}</label>
        <div className="input-group mb-3">
          <input
            type={"password"}
            className="form-control"
            id={"password"}
            name={"password"}
            value={password}
            onChange={(e) => onFormChange(e)}
            placeholder={"Enter your password"}
            disabled={isLoading}
            required={true}
          />
        </div>
        <div>
          <div className="input-group mb-3">
            <input
              type="checkbox"
              className="form-check-input"
              id={"rememberPassword"}
              name={"rememberPassword"}
              checked={rememberPassword}
              onChange={(e) => onFormChange(e)}
              disabled={isLoading}
              required={false}
            />
            <label className="formLabel" htmlFor={"rememberPassword"}>
              {"Remember me"}
            </label>
          </div>
        </div>
      </form>
      <button className="btn-primary formButton" onClick={onLogin}>
        Login
      </button>
    </div>
  );
}

export default LoginForm;
