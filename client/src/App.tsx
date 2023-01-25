import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Header } from 'semantic-ui-react';

function App() {
  return (
    <div className="App">
      <Header as={'h2'} icon= 'users' content = 'Reactivities'/>
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
    </div>
  );
}

export default App;
