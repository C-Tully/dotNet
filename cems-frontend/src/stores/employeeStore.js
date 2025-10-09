import { defineStore } from "pinia";
import {
  //getEmployees,
  createEmployee,
} from "@/services/employeeService.js";

//Note: this is just here for practice work.
const API_URL = "http://localhost:5022/api/employees";

export const useEmployeeStore = defineStore("employee", {
  state: () => ({
    employees: [],
    loading: false,
    error: null,
  }),

  actions: {
    async fetchEmployees() {
      this.loading = true;
      this.error = null;

      try {
        const resp = fetch(API_URL);
        if (!resp.ok) throw new Error("Network response err");

        const data = (await resp).json();
        if (Array.isArray(data) && data.length > 0) {
          this.employees = data;
        } else {
          this.employees = [];
        }
      } catch (err) {
        this.error = err.message || "Failed to fetch employees";
      } finally {
        this.loading = false;
      }

      // try {
      //   const response = await getEmployees();
      //   this.emploees = response.data;
      // } catch (err) {
      //   this.error = err;
      // } finally {
      //   this.loading = false;
      // }
    },
    async addEmployee(employeeData) {
      this.loading = true;
      this.error = null;

      try {
        const response = createEmployee(employeeData);
        this.employees.push(response.data);
      } catch (err) {
        this.error = err;
      } finally {
        this.loading = false;
      }
    },
  },
});
