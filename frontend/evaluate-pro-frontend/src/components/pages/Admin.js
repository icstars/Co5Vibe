import React, { useState, useEffect } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';

const User = () => {
    const [users, setUsers] = useState([]);
    const [userId, setUserId] = useState('');
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [email, setEmail] = useState('');
    const [title, setTitle] = useState('');
    
    useEffect(() => {
        axios.get('http://localhost:3000/api/employees')
             .then(response => setUsers(response.data))
             .catch(error => console.error(error));
    }, []);

    const addUser = () => {
        axios.post('http://localhost:3000/api/employees', { firstName, lastName, email, title })
             .then(response => setUsers([...users, response.data]))
             .catch(error => console.error(error));        
    };

    return (
        <div className="container-fluid width:100% mt-5">
            <h1 className="mb-4">User Management</h1>
            <div className="mb-4">
                <h3 className="mb-3">User List</h3>
                <ul className="list-group">
                    {users.map(user => (
                        <li key={user.id} className="list-group-item">
                            {user.firstName} {user.lastName} - {user.email} ({user.title})
                        </li>
                    ))}
                </ul>
            </div>
            <div className="card p-4">
                <h3 className="card-title mb-3">Add New User</h3>
                <div className="mb-3">
                    <label htmlFor="userId" className="form-label">User ID</label>
                    <input
                        type="text"
                        className="form-control"
                        id="userId"
                        placeholder="Enter User ID"
                        value={userId}
                        onChange={e => setUserId(e.target.value)}
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="firstName" className="form-label">First Name</label>
                    <input
                        type="text"
                        className="form-control"
                        id="firstName"
                        placeholder="Enter First Name"
                        value={firstName}
                        onChange={e => setFirstName(e.target.value)}
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="lastName" className="form-label">Last Name</label>
                    <input
                        type="text"
                        className="form-control"
                        id="lastName"
                        placeholder="Enter Last Name"
                        value={lastName}
                        onChange={e => setLastName(e.target.value)}
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="email" className="form-label">Email</label>
                    <input
                        type="email"
                        className="form-control"
                        id="email"
                        placeholder="Enter Email"
                        value={email}
                        onChange={e => setEmail(e.target.value)}
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="title" className="form-label">Title</label>
                    <input
                        type="text"
                        className="form-control"
                        id="title"
                        placeholder="Enter Title"
                        value={title}
                        onChange={e => setTitle(e.target.value)}
                    />
                </div>
                <button onClick={addUser} className="btn btn-primary">Add User</button>
            </div>
        </div>
    );
};

export default User;


// import React from 'react';
// import 'bootstrap/dist/css/bootstrap.min.css'; 
// import navbar from './navigations/NavBar';
// const Profile = () => {
//   return (
// <section style={{ backgroundColor: "#eee", minHeight: '100vh', width:'100vw' }}>
//   <div className="container py-5">
//     <div className="row">
//       <div className="col">
//         <nav
//           aria-label="breadcrumb"
//           className="bg-body-tertiary rounded-3 p-3 mb-4"
//         >
//           <ol className="breadcrumb mb-0">
//             <li className="breadcrumb-item">
//               <a href="#">Home</a>
//             </li>
//             <li className="breadcrumb-item">
//               <a href="#">User</a>
//             </li>
//             <li className="breadcrumb-item active" aria-current="page">
//               User Profile
//             </li>
//           </ol>
//         </nav>
//       </div>
//     </div>
//     <div className="row">
//       <div className="col-lg-4">
//         <div className="card mb-4">
//           <div className="card-body text-center">
//             <img
//               src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava3.webp"
//               alt="avatar"
//               className="rounded-circle img-fluid"
//               style={{ width: 150 }}
//             />
//             <h5 className="my-3">John Smith</h5>
//             <p className="text-muted mb-1">Full Stack Developer</p>
//             <p className="text-muted mb-4">Bay Area, San Francisco, CA</p>
//             <div className="d-flex justify-content-center mb-2">
//               <button
//                 type="button"
//                 data-mdb-button-init=""
//                 data-mdb-ripple-init=""
//                 className="btn btn-primary"
//               >
//                 Follow
//               </button>
//               <button
//                 type="button"
//                 data-mdb-button-init=""
//                 data-mdb-ripple-init=""
//                 className="btn btn-outline-primary ms-1"
//               >
//                 Message
//               </button>
//             </div>
//           </div>
//         </div>
//         <div className="card mb-4 mb-lg-0">
//           <div className="card-body p-0">
//             <ul className="list-group list-group-flush rounded-3">
//               <li className="list-group-item d-flex justify-content-between align-items-center p-3">
//                 <i className="fas fa-globe fa-lg text-warning" />
//                 <p className="mb-0">https://mdbootstrap.com</p>
//               </li>
//               <li className="list-group-item d-flex justify-content-between align-items-center p-3">
//                 <i className="fab fa-github fa-lg text-body" />
//                 <p className="mb-0">mdbootstrap</p>
//               </li>
//               <li className="list-group-item d-flex justify-content-between align-items-center p-3">
//                 <i
//                   className="fab fa-twitter fa-lg"
//                   style={{ color: "#55acee" }}
//                 />
//                 <p className="mb-0">@mdbootstrap</p>
//               </li>
//               <li className="list-group-item d-flex justify-content-between align-items-center p-3">
//                 <i
//                   className="fab fa-instagram fa-lg"
//                   style={{ color: "#ac2bac" }}
//                 />
//                 <p className="mb-0">mdbootstrap</p>
//               </li>
//               <li className="list-group-item d-flex justify-content-between align-items-center p-3">
//                 <i
//                   className="fab fa-facebook-f fa-lg"
//                   style={{ color: "#3b5998" }}
//                 />
//                 <p className="mb-0">mdbootstrap</p>
//               </li>
//             </ul>
//           </div>
//         </div>
//       </div>
//       <div className="col-lg-8">
//         <div className="card mb-4">
//           <div className="card-body">
//             <div className="row">
//               <div className="col-sm-3">
//                 <p className="mb-0">Full Name</p>
//               </div>
//               <div className="col-sm-9">
//                 <p className="text-muted mb-0">Johnatan Smith</p>
//               </div>
//             </div>
//             <hr />
//             <div className="row">
//               <div className="col-sm-3">
//                 <p className="mb-0">Email</p>
//               </div>
//               <div className="col-sm-9">
//                 <p className="text-muted mb-0">example@example.com</p>
//               </div>
//             </div>
//             <hr />
//             <div className="row">
//               <div className="col-sm-3">
//                 <p className="mb-0">Phone</p>
//               </div>
//               <div className="col-sm-9">
//                 <p className="text-muted mb-0">(097) 234-5678</p>
//               </div>
//             </div>
//             <hr />
//             <div className="row">
//               <div className="col-sm-3">
//                 <p className="mb-0">Mobile</p>
//               </div>
//               <div className="col-sm-9">
//                 <p className="text-muted mb-0">(098) 765-4321</p>
//               </div>
//             </div>
//             <hr />
//             <div className="row">
//               <div className="col-sm-3">
//                 <p className="mb-0">Address</p>
//               </div>
//               <div className="col-sm-9">
//                 <p className="text-muted mb-0">Bay Area, San Francisco, CA</p>
//               </div>
//             </div>
//           </div>
//         </div>
//         <div className="row">
//           <div className="col-md-6">
//             <div className="card mb-4 mb-md-0">
//               <div className="card-body">
//                 <p className="mb-4">
//                   <span className="text-primary font-italic me-1">
//                     assigment
//                   </span>{" "}
//                   Project Status
//                 </p>
//                 <p className="mb-1" style={{ fontSize: ".77rem" }}>
//                   Web Design
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "80%" }}
//                     aria-valuenow={80}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   Website Markup
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "72%" }}
//                     aria-valuenow={72}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   One Page
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "89%" }}
//                     aria-valuenow={89}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   Mobile Template
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "55%" }}
//                     aria-valuenow={55}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   Backend API
//                 </p>
//                 <div className="progress rounded mb-2" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "66%" }}
//                     aria-valuenow={66}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//               </div>
//             </div>
//           </div>
//           <div className="col-md-6">
//             <div className="card mb-4 mb-md-0">
//               <div className="card-body">
//                 <p className="mb-4">
//                   <span className="text-primary font-italic me-1">
//                     assigment
//                   </span>{" "}
//                   Project Status
//                 </p>
//                 <p className="mb-1" style={{ fontSize: ".77rem" }}>
//                   Web Design
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "80%" }}
//                     aria-valuenow={80}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   Website Markup
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "72%" }}
//                     aria-valuenow={72}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   One Page
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "89%" }}
//                     aria-valuenow={89}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   Mobile Template
//                 </p>
//                 <div className="progress rounded" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "55%" }}
//                     aria-valuenow={55}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//                 <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
//                   Backend API
//                 </p>
//                 <div className="progress rounded mb-2" style={{ height: 5 }}>
//                   <div
//                     className="progress-bar"
//                     role="progressbar"
//                     style={{ width: "66%" }}
//                     aria-valuenow={66}
//                     aria-valuemin={0}
//                     aria-valuemax={100}
//                   />
//                 </div>
//               </div>
//             </div>
//           </div>
//         </div>
//       </div>
//     </div>
//   </div>
// </section>
//   )
// }
// export default Profile;