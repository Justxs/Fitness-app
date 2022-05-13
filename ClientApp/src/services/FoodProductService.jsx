/* eslint-disable react-hooks/rules-of-hooks */
import useAPI from "../hooks/useAPI";

export default class FoodProductService {
  fetch = useAPI();

  async getFoodProducts() {
    return this.fetch({ requestType: "get", requestURL: "/FoodProducts" });
  }

  async getFoodProductById(id) {
    return this.fetch({
      requestType: "get",
      requestURL: `/FoodProducts/${id}`,
    });
  }

  async addFoodProduct(product) {
    return this.fetch({
      requestType: "post",
      requestURL: `/FoodProducts/`,
      requestBody: product,
    });
  }

  async deleteFoodProduct(id) {
    return this.fetch({
      requestType: "delete",
      requestURL: `/FoodProducts/${id}`,
    });
  }
}
