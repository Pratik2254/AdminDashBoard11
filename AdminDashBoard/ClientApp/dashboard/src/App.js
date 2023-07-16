
import React from 'react'
import { Routes, Route } from 'react-router-dom'

import SideNav from './components/SideNav';
import Homes from './components/Homes';
import About from './components/About';
import Settings from './components/Settings';
import NavBar from './components/NavBar';
import SignIn from './components/SignIn';
import SignUp from './components/SignUp';

export default function App() {

    return (
        <div className="App">
            <NavBar />
            <SideNav />

            <Routes>
                <Route path='/' exact element={<Homes />}></Route>
                <Route path='/about' exact element={<About />}></Route>
                <Route path='/settings' exact element={<Settings />}></Route>
                <Route path='/signin' exact element={<SignIn />}></Route>
                <Route path='/signup' exact element={<SignUp />}></Route>
            </Routes>
            

        </div>
    );
}