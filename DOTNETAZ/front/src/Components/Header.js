import {useState} from "react";
import classes from '../Styles/Header.module.css'
import List from "./UI/List/List";
import Burger from "./UI/Burger/Burger";
import Input from "./UI/Input/Input";
import list from "./UI/List/List";
import burger from "./UI/Burger/Burger";

const Header = () => {

    let listItems = [
        {id: 0, name: `Home`},
        {id: 1, name: `What's new`},
        {id: 2, name: `About`}
    ];

    return (
        <header className={classes.headerMain}>
            <nav className={classes.navbarItems}>
                <div className={classes.navLogo}>
                    <a href='#'>
                        <h1 style={{whiteSpace: 'nowrap'}}>
                            DOT-NET.AZ
                        </h1>
                    </a>
                </div>

                <div className={classes.rightSide}>
                    <List items={listItems}/>
                    <Burger/>
                </div>

            </nav>
        </header>
    );
};


export default Header;