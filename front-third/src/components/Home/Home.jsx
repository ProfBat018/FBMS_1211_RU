import React from "react";
import Navbar from "../Navbar/Navbar";
import classes from "./home.module.scss"
import Sidebar from "../Sidebar/Sidebar";
function Home() {
    return (
        <div>
            <Navbar/>
            <div>
                <Sidebar/>
            </div>

            <h1>Home</h1>
        </div>
    );
}

export default Home;
