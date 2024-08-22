import React, { useState, useEffect } from 'react';
import axios from 'axios';

const Employee = () => {
    const [Employee, setEmployees] = useState([]);
    const [EmployeeId, setEmployeeId] = useState();
    const [FName, setFName] = useState('');
    const [LName, setLName] = useState('');
    const [Email, setEmail] = useState('');
    const [Title, setTitle] = useState('');
    const [Score, setScore] = useState('');

    useEffect(() => {
        axios.get('http://localhost:3000/api/employees')
             .then(response => setEmployees(response.data))
             .catch(error => console.error(error));
    }, []);

    const addEmployee = () => {
        axios.post('http://localhost:3000/api/employees',{ FName,LName,Email,EmployeeId,score})
             .then(response => setEmployees([...employees, response.data]))
             .catch(error => console.error(error));        
    };

    return (
        <div>
            <h1>Employees</h1>
            <ul>
                {employees.map(employee => (
                    <li key={employee.id}>{employee.FName}{employee.LName}{employee.Email} -Score: {employee.score}</li>
                ))}
            </ul>
            <input
                type="text"
                placeholder="Employee Id"
                value={EmployeeId}
                onChange={e => setEmployeeId(e.target.value)}
            />
            <input
                type="text"
                placeholder="First Name"
                value={FName}
                onChange={e => setFName(e.target.value)}
            />
            <input
                type="text"
                placeholder="Last Name"
                value={LName}
                onChange={e => setLName(e.target.value)}
            />
            <input
                type="email"
                placeholder="Email"
                value={Email}
                onChange={e => setEmail(e.target.value)}
            />
            <input
                type="number"
                placeholder="Score"
                value={score}
                onChange={e => setScore(e.target.value)}
            />
            <button onClick={addEmployee}>Add Employee</button>
        </div>         
    );
};

export default Employee;