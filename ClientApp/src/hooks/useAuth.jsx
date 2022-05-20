/* eslint-disable react-hooks/exhaustive-deps */
import propTypes from "prop-types";
import { createContext, useContext, useState, useEffect, useMemo } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";

const AuthContext = createContext();

AuthProvider.propTypes = {
  children: propTypes.node.isRequired,
};

export function AuthProvider({ children }) {
  const api = axios.create({
    baseURL: "https://localhost:44325/api/Users/",
  });
  const headers = {
    withCredentials: true,
  };

  const [username, setUsername] = useState();
  const [errors, setErrors] = useState();
  const [loading, setLoading] = useState(false);
  const [loadingInitial, setLoadingInitial] = useState(true);

  const navigate = useNavigate();

  useEffect(() => {
    api
      .post("isloggedIn", null, headers)
      .then((response) => {
        if (response.data !== false) {
          setUsername(response.data);
        }
      })
      .catch((errors) => {
        setErrors(errors);
        console.log(errors);
        setUsername(undefined);
      })
      .finally(() => setLoadingInitial(false));
  }, []);

  async function signIn(username, password, rememberPassword) {
    setLoading(true);

    api
      .post(
        "login",
        {
          username: username,
          password: password,
          rememberPassword: rememberPassword,
        },
        headers
      )
      .then((response) => {
        setUsername(response);
      })
      .catch((errors) => {
        setErrors(errors.response.data);
      })
      .finally(() => setLoading(false));
  }

  async function signOut() {
    api
      .post("logout", null, headers)
      .then(() => setUsername(undefined))
      .then(() => navigate("login"));
  }

  const memoedValue = useMemo(
    () => ({
      username,
      loading,
      errors,
      signIn,
      signOut,
    }),
    [username, loading, errors]
  );

  return (
    <AuthContext.Provider value={memoedValue}>
      {!loadingInitial && children}
    </AuthContext.Provider>
  );
}

export default function useAuth() {
  return useContext(AuthContext);
}
