<template>
  <div>
    <h1>Employee Form</h1>
    <ul>
      <li v-for="employee in employes" :key="employee.employeeId">
        {{ employee.firstName }} - {{ employee.lastName }} -
        {{ employee.salary }}
      </li>
    </ul>
  </div>
</template>
<script>
import { getEmployees } from "../services/employeeService";

export default {
  name: "EmployeesList",
  data() {
    return {
      employees: [],
    };
  },
  async created() {
    try {
      const response = await getEmployee();
      this.employees = response.data;
    } catch (err) {
      console.error(err);
    }
  },
};
</script>
