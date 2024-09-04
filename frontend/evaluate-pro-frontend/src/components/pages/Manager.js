import React, { useEffect, useState } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';

const Manager = () => {
    const [users, setUsers] = useState([]);

    useEffect(() => {
        const fetchUsers = async () => {
            try {
                const response = await axios.get('/api/User');
                console.log(response.data);  // Log the data to see if it's correct
                setUsers(response.data);
            } catch (error) {
                console.error('Error fetching employee data:', error);
            }
        };

        fetchUsers();
    }, []);

    return (
        <div className="container-fluid">
            <h1 className="my-4">Manager Page</h1>
            <table className="table table-bordered">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Title</th>
                    </tr>
                </thead>
                <tbody>
                    {users.map((user) => (
                        <tr key={user.id}>
                            <td>{user.id}</td>
                            <td>{user.firstname}</td>
                            <td>{user.lastname}</td>
                            <td>{user.title}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default Manager;
