<template>
  <div>
    <h1>Employee List</h1>
    <ul>
      <li v-for="employee in employees" :key="employee.employeeId">
        {{ employee.firstName }} - {{ employee.lastName }} -
        {{ employee.department }} -
        {{ employee.salary }}
      </li>
    </ul>
  </div>
</template>
<script>
import { getEmployees } from "../../services/employeeService.js";

export default {
  name: "EmployeeList",
  data() {
    return {
      employees: [],
    };
  },
  async created() {
    try {
      const response = await getEmployees();
      this.employees = response.data;
      console.log("response Data::", this.employees);
    } catch (err) {
      console.error(`EmployeeList:: ${err}`);
    }
  },
};
</script>
