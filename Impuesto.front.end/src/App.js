import React, { useState, useEffect } from 'react';
import axios from 'axios';
import './index.css';
import './styles.css'; 

function App() {
  const [contribuyentes, setContribuyentes] = useState([]);
  const [selectedRncCedula, setSelectedRncCedula] = useState(null);
  const [selectedContribuyente, setSelectedContribuyente] = useState(null);
  const [rncCedula, setRncCedula] = useState('');
  const [searchError, setSearchError] = useState(false); 

  useEffect(() => {
    
    fetchContribuyentes();
  }, []);

  const fetchContribuyentes = async () => {
    try {
      const response = await axios.get('https://localhost:7217/api/ComprobantesFiscales/Contribuyentes');
      setContribuyentes(response.data);
    } catch (error) {
      console.error('Error al obtener los contribuyentes:', error);
    }
  };

  const handleSearch = async () => {
    try {
      const response = await axios.get(`https://localhost:7217/api/ComprobantesFiscales/${rncCedula}`);
      setSelectedContribuyente(response.data);
      setSearchError(false); 
    } catch (error) {
      console.error('Error al buscar el contribuyente:', error);
      setSearchError(true); 
    }
  };

  const handleContribuyenteClick = async (rncCedula) => {
    try {
      const response = await axios.get(`https://localhost:7217/api/ComprobantesFiscales/${rncCedula}`);
      setSelectedContribuyente(response.data);
      setSelectedRncCedula(rncCedula);
    } catch (error) {
      console.error('Error al obtener la información del contribuyente:', error);
    }
  };

  return (
    <div className="container">
      <div className="search-container">
        <input type="text" placeholder='RNC/CEDULA' value={rncCedula} onChange={(e) => setRncCedula(e.target.value)} />
        <button onClick={handleSearch}>Buscar</button>
        <div className="button-container"> {/* Contenedor adicional para el botón */}
          <button onClick={handleSearch}>Filtrar Comprobantes</button>
        </div>
      </div>

      {searchError && ( // Mostrar mensaje de error si searchError es true
        <div className="error-message">
          El campo RNC/Cédula está vacío. Por favor, ingrese un valor antes de buscar.
        </div>
      )}
      {selectedContribuyente && !searchError && ( // Mostrar información del contribuyente solo si no hay error de búsqueda
        <div>
          <h2>Información del Contribuyente Seleccionado:</h2>
          <div className="contribuyente-info">
            <table>
              <tbody>
                <tr>
                  <td>Monto Total:</td>
                  <td>{selectedContribuyente.totalMonto} RD$</td>
                </tr>
             
                <tr>
                  <td>TOTALITBIS:</td>
                  <td>{selectedContribuyente.totalITBIS} RD$</td>
                </tr>
              </tbody>
            </table>
          </div>
          <h2>Comprobantes Fiscales:</h2>
          <div className="comprobantes-container">
            <table>
              <thead>
                <tr>
                  <th>NCF</th>
                  <th>Monto</th>
                  <th>ITBIS 18%</th>
                </tr>
              </thead>
              <tbody>
                {selectedContribuyente.comprobantes.map((comprobante) => (
                  <tr key={comprobante.id}>
                    <td>{comprobante.ncf}</td>
                    <td>{comprobante.monto} RD$</td>
                    <td>{comprobante.itbis18} RD$</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>
      )}
      <h2>Lista de Contribuyentes:</h2>
      <div className="table-container">
        <table>
          <thead>
            <tr>
              <th>RNC/Cédula</th>
              <th>Nombre</th>
              <th>Tipo</th>
              <th>Estatus</th>
            </tr>
          </thead>
          <tbody>
            {contribuyentes.map((contribuyente) => (
              <tr
                key={contribuyente.rncCedula}
                onClick={() => handleContribuyenteClick(contribuyente.rncCedula)}
                className={selectedRncCedula === contribuyente.rncCedula ? 'selected' : ''}
              >
                <td>{contribuyente.rncCedula}</td>
                <td>{contribuyente.nombre}</td>
                <td>{contribuyente.tipo}</td>
                <td>{contribuyente.estatus}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default App;
