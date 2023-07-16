import * as React from 'react';
import MuiAppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import { useNavigate } from 'react-router-dom';
import { styled } from '@mui/material';

export default function NavBar() {
  const navigate=useNavigate();
  const AppBar = styled(MuiAppBar, {
    })(({ theme }) => ({
    zIndex: theme.zIndex.drawer + 1,
    
  }));

  return (
    
    <Box sx={{ flexGrow: 1, marginBottom:0 }}>
      <AppBar position="fixed">
        <Toolbar>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="menu"
            sx={{ mr: 2 }}
          >
            <MenuIcon />
          </IconButton>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            MySHoes
          </Typography>
          <Button color="inherit" onClick={()=>{navigate("/signin")}}>Login</Button>
          <Button color="inherit" onClick={()=>{navigate("/signup")}}>Register</Button>
        </Toolbar>
      </AppBar>
    </Box>
  );
}