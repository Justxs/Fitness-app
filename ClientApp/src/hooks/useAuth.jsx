/* eslint-disable react-hooks/exhaustive-deps */
import propTypes from "prop-types";
import { createContext, useContext, useState, useEffect } from "react";

const DUMMY_ROLES = {
  ADMIN: "Administrator",
  USER: "User",
};

const DUMMY_USER = {
  email: "dummy.user@domain.com",
  password: "p455w0rd",
  role: DUMMY_ROLES.ADMIN,
};

const AuthContext = createContext(null);

export const useAuth = () => useContext(AuthContext);

AuthProvider.propTypes = {
  children: propTypes.node.isRequired,
};

export function AuthProvider({ children }) {
  const auth = useProvideAuth();
  return <AuthContext.Provider value={auth}>{children}</AuthContext.Provider>;
}

const useProvideAuth = () => {
  const setLocalStorage = (value) => localStorage.setItem("isLoggedIn", value);
  const getLocalStorage = () => localStorage.getItem("isLoggedIn") === "true";
  const removeLocalStorage = () => localStorage.removeItem("isLoggedIn");

  const [user, setUser] = useState(null);
  const [isLoggedIn, setLoginStatus] = useState(getLocalStorage);

  const setAuth = (state) => {
    setUser(DUMMY_USER);
    if (!state) setUser(null);
    setLoginStatus(state);
    setLocalStorage(state);
  };

  useEffect(() => {
    //TO DO: replace with data fetch from server
    const localAuthState = getLocalStorage();
    setAuth(localAuthState);
  }, []);

  const signIn = (email, password) =>
    new Promise((resolve, reject) => {
      if (email !== DUMMY_USER.email || password !== DUMMY_USER.password) {
        //reject
      } else {
        setAuth(true);
        resolve("Logged in successfully");
      }
    });

  const signOut = () =>
    new Promise((resolve, reject) => {
      if (!isLoggedIn || user === null)
        reject(new Error("You are already logged out"));

      removeLocalStorage();
      setAuth(false);
      resolve("Logged out successfully");
    });

  return {
    signIn,
    signOut,
    isLoggedIn,
    user,
  };
};
