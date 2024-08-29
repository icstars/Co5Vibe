import React from 'react'
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom'
import Login from './components/login.components.js'
import User from './components/User.js'
import Profile from './components/Profile.js'
function App() {
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
                  <Link className="nav-link" to={'/sign-in'}>
                    Login
                  </Link>
                </li>
              </ul>
            </div>
          </div>
        </nav>
        <div className="auth-wrapper">
          <div className="auth-inner">
            <Routes>
              <Route exact path="/" element={<Login />} />
              <Route path="/sign-in" element={<Login />} />
              <Route path="/User" element={<User/>} />
              <Route path="/Profile" element={<Profile/>}/>           
               </Routes>
          </div>
        </div>
      </div>
    </Router>
  )
}
export default App;
