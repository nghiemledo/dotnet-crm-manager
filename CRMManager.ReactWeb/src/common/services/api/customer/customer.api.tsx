import axios from 'axios';
import { CreateCustomer } from '../../../models/customer';

const customerAPIUrl = 'https://localhost:7275/api/customer';

export async function getAllCustomers() {
  const response = await axios.get(customerAPIUrl);
  return response.data;
}

export async function createCustomer(customer: CreateCustomer) {
  const response = await axios.post(customerAPIUrl, customer);
  return response.data;
}