/* eslint-disable react-hooks/rules-of-hooks */
import useAPI from "../hooks/useAPI";

export default class FoodRecordService {
  fetch = useAPI();

  async getFoodRecords() {
    return this.fetch({
      requestType: "get",
      requestController: "/FoodRecords",
      requestPostfix: "",
    });
  }

  async getFoodStatistics() {
    return this.fetch({
      requestType: "get",
      requestController: "/FoodRecords",
      requestPostfix: "/daily",
    });
  }

  async getFoodRecordById(id) {
    return this.fetch({
      requestType: "get",
      requestController: "/FoodRecords",
      requestPostfix: `/${id}`,
    });
  }

  async addFoodRecord(record) {
    return this.fetch({
      requestType: "post",
      requestController: `/FoodRecords`,
      requestPostfix: "/",
      requestBody: record,
    });
  }

  async deleteFoodRecord(id) {
    return this.fetch({
      requestType: "delete",
      requestController: "/FoodRecords",
      requestPostfix: `/${id}`,
    });
  }
}
