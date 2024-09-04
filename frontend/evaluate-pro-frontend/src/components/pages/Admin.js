import React, { useState, useEffect } from "react";
import axios from "axios";
import "bootstrap/dist/css/bootstrap.min.css";
import "./user-edit.css";

const User = () => {
  const [users, setUsers] = useState([]);
  const [userId, setUserId] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [title, setTitle] = useState("");
    const [supervisorName, setSupervisorName] = useState('');


  useEffect(() => {
    axios
      .get("http://localhost:3000/api/employees")
      .then((response) => setUsers(response.data))
      .catch((error) => console.error(error));
  }, []);

  const addUser = () => {
    axios
      .post("http://localhost:3000/api/employees", {
        firstName,
        lastName,
        email,
        title,
      supervisorName})
      .then((response) => setUsers([...users, response.data]))
      .catch((error) => console.error(error));
  };

  return (
    <div className="container-fluid mt-5 containerwrapper">
      <div className="auth-inner">
        <h1 className="mb-4 title-user-edit">User Management</h1>
        <div className="mb-4">
          <h3 className="mb-3">User List</h3>
          <ul className="list-group">
            {users.map((user) => (
              <li key={user.id} className="list-group-item">
                {user.firstName} {user.lastName} - {user.email} ({user.title})
              </li>
            ))}
          </ul>
        </div>
        <div className="card p-4">
          <h3 className="card-title mb-3">Add New User</h3>
          <div className="mb-3">
            <label htmlFor="userId" className="form-label">
              User ID
            </label>
            <input
              type="text"
              className="form-control"
              id="userId"
              placeholder="Enter User ID"
              value={userId}
              onChange={(e) => setUserId(e.target.value)}
            />
          </div>
          <div className="mb-3">
            <label htmlFor="firstName" className="form-label">
              First Name
            </label>
            <input
              type="text"
              className="form-control"
              id="firstName"
              placeholder="Enter First Name"
              value={firstName}
              onChange={(e) => setFirstName(e.target.value)}
            />
          </div>
          <div className="mb-3">
            <label htmlFor="lastName" className="form-label">
              Last Name
            </label>
            <input
              type="text"
              className="form-control"
              id="lastName"
              placeholder="Enter Last Name"
              value={lastName}
              onChange={(e) => setLastName(e.target.value)}
            />
          </div>
          <div className="mb-3">
            <label htmlFor="email" className="form-label">
              Email
            </label>
            <input
              type="email"
              className="form-control"
              id="email"
              placeholder="Enter Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
          </div>
                <div className="mb-3">
                    <label htmlFor="text" className="form-label">Supervisor Name</label>
                    <input
                        type="text"
                        className="form-control"
                        id="supervisorName"
                        placeholder="Enter Supervisor Name"
                        value={email}
                        onChange={e => setSupervisorName(e.target.value)}
                    />
                </div>
          <div className="mb-3">
            <label htmlFor="title" className="form-label">
              Title
            </label>
            <input
              type="text"
              className="form-control"
              id="title"
              placeholder="Enter Title"
              value={title}
              onChange={(e) => setTitle(e.target.value)}
            />
          </div>
          <button onClick={addUser} className="btn btn-primary">
            Add User
          </button>
        </div>
      </div>
    </div>
  );
};

export default User;
