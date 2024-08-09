import { Customer } from '../../../common/models/customer';

export const CustomerList = ({ customers }: any) => {
  return (
    <>
      <table className="table table-striped">
        <thead>
          <tr>
            <th scope="col">Name</th>
            <th scope="col">Tax Number</th>
            <th scope="col">Street</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {customers.map((cus: Customer, index: number) => {
            return (
              <tr key={index}>
                <td>{cus.name}</td>
                <td>{cus.taxNumber}</td>
                <td>{cus.street}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </>
  );
};
