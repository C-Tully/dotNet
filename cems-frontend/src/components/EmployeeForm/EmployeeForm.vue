<template>
  <div>
    <form @submit.prevent="handleSubmit">
      <div v-for="(item, index) in formConfig" :key="index">
        <label :for="item?.label">{{ item?.label }}</label>
        <input :type="item.type" v-model="formData[item.label]" />
      </div>
      <button type="submit">Submit</button>
    </form>
  </div>
</template>
<script>
export default {
  name: "EmployeeForm",
  data() {
    return {
      formConfig: [
        { type: "text", label: "firstName" },
        { type: "text", label: "lastName" },
        { type: "text", label: "department" },
        { type: "number", label: "salary" },
      ],
      formData: {},
    };
  },
  mounted() {
    console.log("start::", this.formConfig);
  },
  methods: {
    handleSubmit() {
      this.$emit("formSubmission", this.formData);
      this.formData = {
        firstName: "",
        lastName: "",
        salary: "",
      };
    },
  },
};
</script>
