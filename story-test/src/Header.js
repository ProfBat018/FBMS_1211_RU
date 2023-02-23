import './Header.css'
import {Button} from "./stories/Button";
import React, { useState } from 'react';

function Header(){ // процедурный компонент, так как это функция
    const [count, setCount] = useState(0);

    return (
      <header>
        <div className="nav-main">
            <ul className="nav-list">
                <li>
                    <Button
                        label={count.toString()}
                        onClick={() => {setCount(count + 1)}}
                        primary
                    />
                </li>
                <li>
                    Home
                </li>
                <li>
                    News
                </li>
            </ul>
        </div>
      </header>
    );
}

export default Header;