import axios from "axios";

//Need to confirm what the correct port is here 14031
const API_URL = "https://localhost:5001/api/employees";

export const getEmployees = () => axios.get(API_URL);
export const getEmployee = (id) => axios.get(`${API_URL}/${id}`);
export const createEmployee = (id) => axios.post(API_URL, employee);
export const updateEmployee = (id, employee) =>
  axios.put(`${API_URL}/${id}`, employee);
export const deleteEMployee = (id) => axios.delete(`${API_URL}/${id}`);
