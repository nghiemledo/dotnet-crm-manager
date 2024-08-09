export const CustomerForm = ({ submit, customer, onChange }: any) => {
  return (
    <>
      <form>
        <div className="mb-3">
          <label htmlFor="name" className="form-label">
            Name
          </label>
          <input type="text" className="form-control" name="name" id="name" placeholder="name" onChange={onChange} value={customer.name} />
        </div>
        <div className="mb-3">
          <label htmlFor="taxnumber" className="form-label">
            TaxNumber
          </label>
          <input
            type="text"
            className="form-control"
            name="taxNumber"
            id="taxnumber"
            placeholder="taxnumber"
            onChange={onChange}
            value={customer.taxNumber}
          />
        </div>
        <div className="mb-3">
          <label htmlFor="street" className="form-label">
            Street
          </label>
          <input type="text" className="form-control" name="street" id="street" placeholder="street" onChange={onChange} value={customer.street} />
        </div>
        <button type="button" className="btn btn-primary" onClick={submit}>
          Submit
        </button>
      </form>
    </>
  );
};
