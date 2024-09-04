import React from 'react'
import { useState } from 'react'
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom'
import Login from './components/pages/login.js'
import User from './components/pages/Admin.js'
import Profile from './components/pages/Profile.js'
import Manager from './components/pages/Manager.js'
function App() {
  const [name, setName] = useState("");

  const onClick = () => {
    localStorage.name = "null"
      localStorage.title = "null"
      localStorage.address = "null"
      localStorage.email = "null"
  }

  return (
    <Router>
      <div className="App">
        <nav className="navbar navbar-expand-lg navbar-light navbar-logo fixed-top">
          <div className="container">
            <Link className="navbar-brand" to={'/sign-in'}>
              Evaluate Pro
            </Link>
            <div className="collapse navbar-collapse" id="navbarTogglerDemo02">
              <ul className="navbar-nav ml-auto">
                <li className="nav-item">
                  <Link className="nav-link" to={'/Profile'}>
                    Home
                  </Link>
                </li>
                <li className="nav-item">
                  <Link className={`nav-link ${localStorage.email != "Kevin@example.com" && "d-none" }`} to={'/User'}>
                    Edit User
                  </Link>
                </li>
                <li className="nav-item">
                  <Link className="nav-link" to={'/sign-in'} onClick={onClick}>
                    Log Out
                  </Link>
                </li>
              </ul>
            </div>
          </div>
        </nav>
        <div className='p-5'>
        
        </div>
        <div className="auth-wrapper">
          
            <Routes>
              <Route exact path="/" element={<Login />} />
              <Route path="/sign-in" element={<Login />} />
              <Route path="/User" element={<User/>} />
              <Route path="/Profile" element={<Profile/>}/>
              <Route path="/Manager" element={<Manager/>}/>           
               </Routes>
          
        </div>
      </div>
    </Router>
  )
}
export default App;