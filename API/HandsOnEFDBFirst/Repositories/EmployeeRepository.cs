using HandsOnEFDBFirst.Entities;
namespace HandsOnEFDBFirst.Repositories
{
    public class EmployeeRepository
    {
        private readonly TrainingDBContext db;
        public EmployeeRepository()
        {
            this.db = new TrainingDBContext();
        }
        public List<Employee> GetEmployees()
        {
            try
            {
                return db.Employees.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Employee GetEmployee(int eid)
        {
            try
            {
                return db.Employees.Find(eid);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
