<template>
  <div>
    <fieldset>
      <input name="A" type="radio" />
      <label for="A">A</label>
      <input name="B" type="radio" />
      <label for="B">B</label>
    </fieldset>
    <EmployeeList v-if="radioMode == 'A'" />
    <!-- <EmployeeForm v-if="radioMode == 'B'" /> -->
    <EmployeeForm @formSubmission="handleFormSubmit" />
  </div>
</template>

<script>
import EmployeeList from "@/components/EmployeeList/EmployeeList.vue";
import EmployeeForm from "@/components/EmployeeForm/EmployeeForm.vue";
import { createEmployee } from "@/services/employeeService.js";

export default {
  name: "EmployeeView",
  components: {
    EmployeeForm,
    EmployeeList,
  },
  data() {
    return {
      radioMode: "A",
    };
  },
  methods: {
    async handleFormSubmit(formData) {
      console.log("EmployeeView::handleFormSubmit::", formData);
      try {
        const response = await createEmployee(formData);
        if (!response.data) console.log("ERROR", response);
      } catch (err) {
        console.log("failed to create employe");
      }
    },
  },
};
</script>
