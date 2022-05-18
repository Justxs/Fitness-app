/* eslint-disable react-hooks/rules-of-hooks */
import useAPI from "../hooks/useAPI";

export default class FoodProductService {
  fetch = useAPI();

  async getFoodProducts() {
    return this.fetch({
      requestType: "get",
      requestController: "/FoodProducts",
      requestPostfix: "",
    });
  }

  async getFoodProductById(id) {
    return this.fetch({
      requestType: "get",
      requestController: "/FoodProducts",
      requestPostfix: `/${id}`,
    });
  }

  async addFoodProduct(product) {
    return this.fetch({
      requestType: "post",
      requestController: `/FoodProducts`,
      requestPostfix: "/",
      requestBody: product,
    });
  }

  async deleteFoodProduct(id) {
    return this.fetch({
      requestType: "delete",
      requestController: "/FoodProducts",
      requestPostfix: `/${id}`,
    });
  }
}
