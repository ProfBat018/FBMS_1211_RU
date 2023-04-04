import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

// Provider - это компонент, который оборачивает наше приложение и передает в него store
// Приложение надо оборачивать, потому что redux - это отдельная библиотека, которая не знает ничего о react.
// Поэтому, чтобы она могла работать с react, нам надо обернуть наше приложение в компонент Provider.
import {Provider} from "react-redux";

// store - это объект, который содержит в себе состояние приложения.
import store from './store';


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <Provider store={store}>
        <App/>
    </Provider>
);

reportWebVitals();
