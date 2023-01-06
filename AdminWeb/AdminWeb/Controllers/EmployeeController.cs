//using system;
//using adminweb.models;
//using system.collections.generic;
//using system.linq;
//using system.web;
//using system.web.mvc;

//namespace adminweb.controllers
//{
//    public class employeecontroller : controller
//    {
//        dbentities db = new dbentities();

//        public actionresult index()
//        {
//            return view(db.admin_employee.tolist());
//        }

//        public actionresult create()
//        {
//            return view();
//        }

//        [httppost]
//        public actionresult create(admin_employee emp)
//        {
//            if (modelstate.isvalid)
//            {
//                db.admin_employee.add(emp);
//                db.savechanges();
//                return redirecttoaction("index");
//            }

//            return view();
//        }

//        //get edit
//        [httpget]
//        public actionresult edit(int id)
//        {
//            admin_employee emp = db.admin_employee.single(x => x.empid == id);
//            if (emp == null)
//            {
//                return httpnotfound();
//            }
//            //viewbag.roleid = new selectlist(db.roles, "roleid", "rolename", emp.roleid);
//            return view("edit", emp);
//        }

//        //post edit
//        [httppost]
//        public actionresult edit(admin_employee emp)
//        {
//            if (modelstate.isvalid)
//            {
//                db.entry(emp).state = entitystate.modified;
//                db.savechanges();
//                return redirecttoaction("index");
//            }
//            //viewbag.roleid = new selectlist(db.roles, "roleid", "rolename", emp.roleid);
//            return view(emp);
//        }

//        //get details
//        public actionresult details(int id)
//        {
//            admin_employee emp = db.admin_employee.find(id);
//            if (emp == null)
//            {
//                return httpnotfound();
//            }
//            return view(emp);
//        }

//        //get delete
//        public actionresult delete(int id)
//        {
//            admin_employee emp = db.admin_employee.find(id);
//            if (emp == null)
//            {
//                return httpnotfound();
//            }
//            return view(emp);

//        }

//        //post delete confirmed
//        [httppost, actionname("delete")]
//        [validateantiforgerytoken]
//        public actionresult deleteconfirmed(int id)
//        {
//            admin_employee admin_employee = db.admin_employee.find(id);
//            db.admin_employee.remove(admin_employee);
//            db.savechanges();
//            return redirecttoaction("index");
//        }

//        protected override void dispose(bool disposing)
//        {
//            base.dispose(disposing);
//        }

//    }
//}