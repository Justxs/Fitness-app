//TODO: auth
//TODO: error handling
import axios from "axios";

export default function useAPI() {
  const baseUrl = "https://localhost:44325";

  async function fetch({ requestType, requestBody, requestURL }) {
    let data;
    try {
      const response = await axios[requestType](
        baseUrl + requestURL,
        requestBody
      );
      data = response.data ? response.data : true;
    } catch (err) {
      //TODO: implement error handling
    }
    return data;
  }
  return fetch;
}
