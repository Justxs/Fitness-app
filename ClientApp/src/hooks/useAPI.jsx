//TODO: auth
//TODO: error handling
import axios from "axios";

export default function useAPI() {
  const headers = {
    withCredentials: true,
  };

  async function fetch({
    requestType,
    requestBody,
    requestController,
    requestPostfix,
  }) {
    const api = axios.create({
      baseURL: "https://localhost:44325/api" + requestController,
      withCredentials: true,
    });
    let data;
    try {
      let response;
      if (requestType === "get") {
        response = await api[requestType](requestPostfix);
      } else {
        response = await api[requestType](requestPostfix, requestBody);
      }
      data = response.data ? response.data : true;
    } catch (err) {
      //TODO: implement error handling
    }
    return data;
  }
  return fetch;
}
