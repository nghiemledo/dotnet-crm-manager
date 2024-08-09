import { useQuery } from 'react-query';
import { getAllCustomers } from '../../common/services/api/customer/customer.api';
import { CustomerList } from './components/customer.list';
import { Link } from 'react-router-dom';

export const CustomerPage = () => {
  const { data, isLoading } = useQuery(['customers'], getAllCustomers);
  return (
    <>
      <div className="row mt-3">
        <div className="col">
          <h1>Customers</h1>
        </div>
      </div>
      <div className="row mt-3">
        <div className="col d-flex justify-content-end">
          <Link className="btn btn-primary" to={'create'}>
            Create
          </Link>
        </div>
      </div>
      <div className="row mt-3">
        <div className="col">
          {isLoading && <p>Loading...</p>}
          {!isLoading && <CustomerList customers={data} />}
        </div>
      </div>
    </>
  );
};
