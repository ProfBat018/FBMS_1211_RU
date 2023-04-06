import logo from './logo.svg';
import './App.css';
import {GoogleOAuthProvider} from '@react-oauth/google';
import Google from "./Google";
import {Route, Routes} from "react-router";
import News from "./components/news";
import React from "react";

function App() {

    return (
        <Routes>
            <Route path={"/news"} element={<News/>}/>
        <Route index={true} path={"main"} element={
            <div className="App">
                <header className="App-header">
                    <img src={logo} className="App-logo" alt="logo"/>
                    <GoogleOAuthProvider
                        clientId="630659407985-c655qvr0st0kj0jbkf4ud1beue5riad8.apps.googleusercontent.com">
                        <Google/>
                    </GoogleOAuthProvider>
                </header>
            </div>
        }/>
        </Routes>

    );
}

export default App;
