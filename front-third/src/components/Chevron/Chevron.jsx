import React, { useState } from 'react';
import './chevron.css';

const Chevron = () => {
    const [isOpen, setIsOpen] = useState(false);

    const handleClick = () => {
        setIsOpen(!isOpen);
    };

    return (
        <div className="chevron-container" onClick={handleClick}>
            <div className={`chevron ${isOpen ? 'open' : ''}`}></div>
        </div>
    );
};

export default Chevron;
